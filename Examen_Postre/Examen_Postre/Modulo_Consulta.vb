Module Modulo_Consulta
    Sub Consulta_Mysql(ByVal miSql As String)

        Conexion_Mysql.Close()
        DS.Tables.Clear()
        DT.Rows.Clear()
        DT.Columns.Clear()
        DS.Clear()

        Conexion_Mysql.Open()
        SC.Connection = Conexion_Mysql
        SC.CommandText = miSql
        DA.SelectCommand = SC
        DA.Fill(DT)
        DS.Tables.Add(DT)
        Conexion_Mysql.Close()

    End Sub
End Module
