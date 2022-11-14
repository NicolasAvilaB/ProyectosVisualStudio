Module Modulo3_Consulta_Sqlite
    Sub Consulta_Sqlite(ByVal miSqlite As String)

        Conexion_Sqlite.Close()
        DS5.Tables.Clear()
        DT5.Rows.Clear()
        DT5.Columns.Clear()
        DS5.Clear()

        Conexion_Sqlite.Open()
        SC5.Connection = Conexion_Sqlite
        SC5.CommandText = miSqlite
        DA5.SelectCommand = SC5
        DA5.Fill(DT5)
        DS5.Tables.Add(DT5)
        Conexion_Sqlite.Close()

    End Sub
End Module
