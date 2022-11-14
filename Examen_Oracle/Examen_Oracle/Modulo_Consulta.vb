Module Modulo_Consulta
    Sub Consulta_Oracle(ByVal miOracle As String)

        Conexion_Oracle.Close()
        DS7.Tables.Clear()
        DT7.Rows.Clear()
        DT7.Columns.Clear()
        DS7.Clear()


        Conexion_Oracle.Open()
        SC7.Connection = Conexion_Oracle
        SC7.CommandText = miOracle
        DA7.SelectCommand = SC7
        DA7.Fill(DT7)
        DS7.Tables.Add(DT7)
        Conexion_Oracle.Close()

    End Sub
End Module
