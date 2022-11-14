Module Modulo_Consulta4
    Sub Consulta(ByVal miSql As String)

        Conexion.Close()
        DS.Tables.Clear()
        DT.Rows.Clear()
        DT.Columns.Clear()
        DS.Clear()

        Conexion.Open()
        SC.Connection = Conexion
        SC.CommandText = miSql
        DA.SelectCommand = SC
        DA.Fill(DT)
        DS.Tables.Add(DT)
        Conexion.Close()

    End Sub
End Module
