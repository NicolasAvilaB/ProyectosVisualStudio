Module Modulo_C_Ancho_Alto_Escala1
    Dim valorprecio As Long
    Sub calculo_escala1()
        'escala 1
        For Each row As DataGridViewRow In NotaVenta.Tabla_Nota.Rows
            'primera fila
            If (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "0.001" And CStr(row.Cells(2).Value) <= "1.000") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("0.001") & "','" & ("1.000") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'segunda fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.001" And CStr(row.Cells(2).Value) <= "1.100") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.001") & "','" & ("1.100") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'tercera fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.101" And CStr(row.Cells(2).Value) <= "1.200") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.101") & "','" & ("1.200") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio


                'cuarta fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.201" And CStr(row.Cells(2).Value) <= "1.300") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.201") & "','" & ("1.300") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'quinta fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.301" And CStr(row.Cells(2).Value) <= "1.400") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.301") & "','" & ("1.400") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'sexta fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.401" And CStr(row.Cells(2).Value) <= "1.500") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.401") & "','" & ("1.500") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'septima fila
                'septima fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.501" And CStr(row.Cells(2).Value) <= "1.600") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.501") & "','" & ("1.600") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'octava fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.601" And CStr(row.Cells(2).Value) <= "1.700") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.601") & "','" & ("1.700") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'novena fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.701" And CStr(row.Cells(2).Value) <= "1.800") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.701") & "','" & ("1.800") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.801" And CStr(row.Cells(2).Value) <= "1.900") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.801") & "','" & ("1.900") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima una fila
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "1.901" And CStr(row.Cells(2).Value) <= "2.000") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("1.901") & "','" & ("2.000") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio


                'decima dos fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.001" And CStr(row.Cells(2).Value) <= "2.100") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.001") & "','" & ("2.100") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima tres fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.101" And CStr(row.Cells(2).Value) <= "2.200") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.101") & "','" & ("2.200") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio


                'decima cuarta fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.201" And CStr(row.Cells(2).Value) <= "2.300") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.201") & "','" & ("2.300") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima quinta fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.301" And CStr(row.Cells(2).Value) <= "2.400") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.301") & "','" & ("2.400") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima sexta fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.401" And CStr(row.Cells(2).Value) <= "2.500") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("2.500") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima septima fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.501" And CStr(row.Cells(2).Value) <= "2.600") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.501") & "','" & ("2.600") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima octava fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.601" And CStr(row.Cells(2).Value) <= "2.700") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.601") & "','" & ("2.700") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'decima novena fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.701" And CStr(row.Cells(2).Value) <= "2.800") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.701") & "','" & ("2.800") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.801" And CStr(row.Cells(2).Value) <= "2.900") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.801") & "','" & ("2.900") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina una fila
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "2.901" And CStr(row.Cells(2).Value) <= "3.000") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.901") & "','" & ("3.000") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina dos fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.001" And CStr(row.Cells(2).Value) <= "3.100") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.001") & "','" & ("3.100") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina tres fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.101" And CStr(row.Cells(2).Value) <= "3.200") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.101") & "','" & ("3.200") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina cuarta fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.201" And CStr(row.Cells(2).Value) <= "3.300") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.201") & "','" & ("3.300") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina quinta fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.301" And CStr(row.Cells(2).Value) <= "3.400") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.301") & "','" & ("3.400") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina sexta fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("2.401") & "','" & ("3.500") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.401" And CStr(row.Cells(2).Value) <= "3.500") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.401") & "','" & ("3.500") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina septima fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.501" And CStr(row.Cells(2).Value) <= "3.600") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.501") & "','" & ("3.600") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina octava fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.601" And CStr(row.Cells(2).Value) <= "3.700") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.601") & "','" & ("3.700") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'vecina novena fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.701" And CStr(row.Cells(2).Value) <= "3.800") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.701") & "','" & ("3.800") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.801" And CStr(row.Cells(2).Value) <= "3.900") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.801") & "','" & ("3.900") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta una fila
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "3.901" And CStr(row.Cells(2).Value) <= "4.000") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("3.901") & "','" & ("4.000") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio


                'treinta dos fila
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.001" And CStr(row.Cells(2).Value) <= "4.100") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.001") & "','" & ("4.100") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta tres fila
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.101" And CStr(row.Cells(2).Value) <= "4.200") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.101") & "','" & ("4.200") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta cuarta fila
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.201" And CStr(row.Cells(2).Value) <= "4.300") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.201") & "','" & ("4.300") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta quinta fila
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.301" And CStr(row.Cells(2).Value) <= "4.400") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.301") & "','" & ("4.400") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio

                'treinta sexta fila
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "0.001" And CStr(row.Cells(3).Value) <= "1.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("0.001") & "','" & ("1.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.001" And CStr(row.Cells(3).Value) <= "1.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.001") & "','" & ("1.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.101" And CStr(row.Cells(3).Value) <= "1.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.101") & "','" & ("1.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.201" And CStr(row.Cells(3).Value) <= "1.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.201") & "','" & ("1.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.301" And CStr(row.Cells(3).Value) <= "1.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.301") & "','" & ("1.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.401" And CStr(row.Cells(3).Value) <= "1.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.401") & "','" & ("1.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.501" And CStr(row.Cells(3).Value) <= "1.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.501") & "','" & ("1.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.601" And CStr(row.Cells(3).Value) <= "1.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.601") & "','" & ("1.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.701" And CStr(row.Cells(3).Value) <= "1.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.701") & "','" & ("1.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.801" And CStr(row.Cells(3).Value) <= "1.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.801") & "','" & ("1.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "1.901" And CStr(row.Cells(3).Value) <= "2.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("1.901") & "','" & ("2.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.001" And CStr(row.Cells(3).Value) <= "2.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.001") & "','" & ("2.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.101" And CStr(row.Cells(3).Value) <= "2.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.101") & "','" & ("2.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.201" And CStr(row.Cells(3).Value) <= "2.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.201") & "','" & ("2.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.301" And CStr(row.Cells(3).Value) <= "2.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.301") & "','" & ("2.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.401" And CStr(row.Cells(3).Value) <= "2.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.401") & "','" & ("2.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.501" And CStr(row.Cells(3).Value) <= "2.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.501") & "','" & ("2.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.601" And CStr(row.Cells(3).Value) <= "2.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.601") & "','" & ("2.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.701" And CStr(row.Cells(3).Value) <= "2.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.701") & "','" & ("2.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.801" And CStr(row.Cells(3).Value) <= "2.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.801") & "','" & ("2.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "2.901" And CStr(row.Cells(3).Value) <= "3.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("2.901") & "','" & ("3.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.001" And CStr(row.Cells(3).Value) <= "3.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.001") & "','" & ("3.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.101" And CStr(row.Cells(3).Value) <= "3.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.101") & "','" & ("3.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.201" And CStr(row.Cells(3).Value) <= "3.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.201") & "','" & ("3.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.301" And CStr(row.Cells(3).Value) <= "3.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.301") & "','" & ("3.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.401" And CStr(row.Cells(3).Value) <= "3.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.401") & "','" & ("3.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.501" And CStr(row.Cells(3).Value) <= "3.600") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.501") & "','" & ("3.600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.601" And CStr(row.Cells(3).Value) <= "3.700") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.601") & "','" & ("3.700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.701" And CStr(row.Cells(3).Value) <= "3.800") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.701") & "','" & ("3.800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.801" And CStr(row.Cells(3).Value) <= "3.900") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.801") & "','" & ("3.900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "3.901" And CStr(row.Cells(3).Value) <= "4.000") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("3.901") & "','" & ("4.000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "4.001" And CStr(row.Cells(3).Value) <= "4.100") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("4.001") & "','" & ("4.100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "4.101" And CStr(row.Cells(3).Value) <= "4.200") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("4.101") & "','" & ("4.200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "4.201" And CStr(row.Cells(3).Value) <= "4.300") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("4.201") & "','" & ("4.300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "4.301" And CStr(row.Cells(3).Value) <= "4.400") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("4.301") & "','" & ("4.400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            ElseIf (CStr(row.Cells(2).Value) >= "4.401" And CStr(row.Cells(2).Value) <= "4.500") And (CStr(row.Cells(3).Value) >= "4.401" And CStr(row.Cells(3).Value) <= "4.500") And (CStr(row.Cells(5).Value) = "BLANCO" Or CStr(row.Cells(5).Value) = "BRONCE" Or CStr(row.Cells(5).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala1 ('" & ("4.401") & "','" & ("4.500") & "','" & ("4.401") & "','" & ("4.500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio
            End If
        Next
    End Sub
End Module
