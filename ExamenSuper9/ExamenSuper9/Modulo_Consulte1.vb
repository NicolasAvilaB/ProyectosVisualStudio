Module Modulo_Consulte1
    Sub Consulta1(ByVal miSql As String)

        Conexion.Close()
        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()

        Conexion.Open()
        SC2.Connection = Conexion
        SC2.CommandText = miSql
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        Conexion.Close()

    End Sub
End Module
