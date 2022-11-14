Module ModuleConsultas
    Sub MiConsulta(ByVal miSql As String)
        conexion.Close()
        DS.Tables.Clear()
        DT.Rows.Clear()
        DT.Columns.Clear()
        DS.Clear()

        conexion.Open()
        SC.Connection = conexion
        SC.CommandText = miSql
        DA.SelectCommand = SC
        DA.Fill(DT)
        DS.Tables.Add(DT)
        conexion.Close()

    End Sub
    Sub MiConsulta2(ByVal misql As String)
        conexion.Close()
        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()

        conexion.Open()
        SC2.Connection = conexion
        SC2.CommandText = misql
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        conexion.Close()
    End Sub
End Module
