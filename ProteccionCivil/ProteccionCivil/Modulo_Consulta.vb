Module Modulo_Consulta
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
    Sub Consulta0(ByVal miSql0 As String)
        Conexion0.Close()
        DS0.Tables.Clear()
        DT0.Rows.Clear()
        DT0.Columns.Clear()
        DS0.Clear()
        Conexion0.Open()
        SC0.Connection = Conexion0
        SC0.CommandText = miSql0
        DA0.SelectCommand = SC0
        DA0.Fill(DT0)
        DS0.Tables.Add(DT0)
        Conexion0.Close()
    End Sub
    Sub Consulta1(ByVal miSql1 As String)
        Conexion1.Close()
        DS1.Tables.Clear()
        DT1.Rows.Clear()
        DT1.Columns.Clear()
        DS1.Clear()
        Conexion1.Open()
        SC1.Connection = Conexion1
        SC1.CommandText = miSql1
        DA1.SelectCommand = SC1
        DA1.Fill(DT1)
        DS1.Tables.Add(DT1)
        Conexion1.Close()
    End Sub
End Module
