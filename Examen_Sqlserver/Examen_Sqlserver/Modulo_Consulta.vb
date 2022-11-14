Module Modulo_Consulta
    Sub Consulta_Sqlserver(ByVal miSqlserver As String)

        Conexion_Sqlserver.Close()
        DS9.Tables.Clear()
        DT9.Rows.Clear()
        DT9.Columns.Clear()
        DS9.Clear()


        Conexion_Sqlserver.Open()
        SC9.Connection = Conexion_Sqlserver
        SC9.CommandText = miSqlserver
        DA9.SelectCommand = SC9
        DA9.Fill(DT9)
        DS9.Tables.Add(DT9)
        Conexion_Sqlserver.Close()

    End Sub
End Module
