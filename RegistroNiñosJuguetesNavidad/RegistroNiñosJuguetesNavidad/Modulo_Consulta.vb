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
    Sub Consulta1(ByVal miSql1 As String)
        Conexion.Close()
        DS1.Tables.Clear()
        DT1.Rows.Clear()
        DT1.Columns.Clear()
        DS1.Clear()
        Conexion.Open()
        SC1.Connection = Conexion
        SC1.CommandText = miSql1
        DA1.SelectCommand = SC1
        DA1.Fill(DT1)
        DS1.Tables.Add(DT1)
        Conexion.Close()
    End Sub
    Sub Consulta2(ByVal miSql2 As String)
        Conexion.Close()
        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()
        Conexion.Open()
        SC2.Connection = Conexion
        SC2.CommandText = miSql2
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        Conexion.Close()
    End Sub
    Sub Consulta3(ByVal miSql3 As String)
        Conexion.Close()
        DS3.Tables.Clear()
        DT3.Rows.Clear()
        DT3.Columns.Clear()
        DS3.Clear()
        Conexion.Open()
        SC3.Connection = Conexion
        SC3.CommandText = miSql3
        DA3.SelectCommand = SC3
        DA3.Fill(DT3)
        DS3.Tables.Add(DT3)
        Conexion.Close()
    End Sub
    Sub Consulta4(ByVal miSql4 As String)
        Conexion.Close()
        DS4.Tables.Clear()
        DT4.Rows.Clear()
        DT4.Columns.Clear()
        DS4.Clear()
        Conexion.Open()
        SC4.Connection = Conexion
        SC4.CommandText = miSql4
        DA4.SelectCommand = SC4
        DA4.Fill(DT4)
        DS4.Tables.Add(DT4)
        Conexion.Close()
    End Sub
    Sub Consulta5(ByVal miSql5 As String)
        Conexion.Close()
        DS5.Tables.Clear()
        DT5.Rows.Clear()
        DT5.Columns.Clear()
        DS5.Clear()
        Conexion.Open()
        SC5.Connection = Conexion
        SC5.CommandText = miSql5
        DA5.SelectCommand = SC5
        DA5.Fill(DT5)
        DS5.Tables.Add(DT5)
        Conexion.Close()
    End Sub
    Sub Consulta6(ByVal miSql6 As String)
        Conexion.Close()
        DS6.Tables.Clear()
        DT6.Rows.Clear()
        DT6.Columns.Clear()
        DS6.Clear()
        Conexion.Open()
        SC6.Connection = Conexion
        SC6.CommandText = miSql6
        DA6.SelectCommand = SC6
        DA6.Fill(DT6)
        DS6.Tables.Add(DT6)
        Conexion.Close()
    End Sub

    Sub Consulta7(ByVal miSql7 As String)
        Conexion.Close()
        DS7.Tables.Clear()
        DT7.Rows.Clear()
        DT7.Columns.Clear()
        DS7.Clear()
        Conexion.Open()
        SC7.Connection = Conexion
        SC7.CommandText = miSql7
        DA7.SelectCommand = SC7
        DA7.Fill(DT7)
        DS7.Tables.Add(DT7)
        Conexion.Close()
    End Sub

    Sub Consulta8(ByVal miSql8 As String)
        Conexion.Close()
        DS8.Tables.Clear()
        DT8.Rows.Clear()
        DT8.Columns.Clear()
        DS8.Clear()
        Conexion.Open()
        SC8.Connection = Conexion
        SC8.CommandText = miSql8
        DA8.SelectCommand = SC8
        DA8.Fill(DT8)
        DS8.Tables.Add(DT8)
        Conexion.Close()
    End Sub
End Module
