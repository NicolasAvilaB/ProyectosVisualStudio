Module Modulo_Consultas

    Sub MiConsulta(ByVal miSql As String)

        conexion.Close()
        DS.Tables.Clear()
        DT.Rows.Clear()
        DT.Columns.Clear()
        DS.Clear()

        conexion.Open()
        SC.Connection = conexion
        SC.CommandText = misql
        DA.SelectCommand = SC
        DA.Fill(DT)
        DS.Tables.Add(DT)
        conexion.Close()

    End Sub

End Module
