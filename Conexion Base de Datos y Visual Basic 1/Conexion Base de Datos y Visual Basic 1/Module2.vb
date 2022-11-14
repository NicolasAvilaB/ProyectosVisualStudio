Module Module2
    Sub Mionsulta(ByVal MiSQL As String)
        Conexion1.Close()
        DS1.Tables.Clear()
        DT1.Rows.Clear()
        DT1.Columns.Clear()
        DS1.Clear()

        Conexion1.Open()
        SC1.Connection = Conexion1
        SC1.CommandText = MiSQL
        DA1.SelectCommand = SC1
        DA1.Fill(DT1)
        DS1.Tables.Add(DT1)
        Conexion1.Close()

    End Sub
End Module
