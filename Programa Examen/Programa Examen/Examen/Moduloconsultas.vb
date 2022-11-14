Module Moduloconsultas
    Sub miconsulta(ByVal misql As String)
        conexion.close()
        ds.tables.clear()
        dt.rows.clear()
        dt.columns.clear()
        ds.clear()

        conexion.open()
        sc.connection = conexion
        sc.CommandText = misql
        da.selectcommand = sc
        da.Fill(dt)
        ds.tables.add(dt)
        conexion.close()
    End Sub
    Sub miconsulta2(ByVal misql As String)
        conexion.Close()
        ds2.Tables.Clear()
        dt2.Rows.Clear()
        dt2.Columns.Clear()
        ds2.Clear()

        conexion.Open()
        sc2.Connection = conexion
        sc2.CommandText = misql
        da2.SelectCommand = sc2
        da2.Fill(dt2)
        ds2.Tables.Add(dt2)
        conexion.Close()
    End Sub
    Sub miconsulta3(ByVal misql As String)
        conexion.Close()
        ds3.Tables.Clear()
        dt3.Rows.Clear()
        dt3.Columns.Clear()
        ds3.Clear()

        conexion.Open()
        sc3.Connection = conexion
        sc3.CommandText = misql
        da3.SelectCommand = sc3
        da3.Fill(dt3)
        ds3.Tables.Add(dt3)
        conexion.Close()
    End Sub
End Module
